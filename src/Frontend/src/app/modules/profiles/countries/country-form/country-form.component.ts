import { CommonModule } from '@angular/common';
import {
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  Signal,
  computed,
  signal,
} from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';
import { Constant } from '../../../shared/constants/constants';
import { HttpService } from '../../../shared/services/http.service';
import { ReloadDataService } from '../../../shared/services/reload-data.service';
import { SharedModule } from '../../../shared/shared.module';
import { handleException } from '../../../shared/utils/handle.exception';
import { ICountry } from '../country/country.interface';

const URL_COUNTRY = `${Constant.URL_BASE}${Constant.URL_COUNTRY}`;

@Component({
  selector: 'srms-country-form',
  standalone: true,
  imports: [
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    ReactiveFormsModule,
    SharedModule,
  ],
  templateUrl: './country-form.component.html',
  styleUrl: './country-form.component.scss',
})
export class CountryFormComponent implements OnInit {
  @Input() country: Signal<ICountry | null> = signal(null);
  @Output('frmCountry') form: EventEmitter<Signal<FormGroup>>;
  public frmCountry: Signal<FormGroup>;
  private regexp =
    '^[0-9A-Za-z]{8}-[0-9A-Za-z]{4}-4[0-9A-Za-z]{3}-[89ABab][0-9A-Za-z]{3}-[0-9A-Za-z]{12}$';

  constructor(
    private snackBar: MatSnackBar,
    private httpService: HttpService,
    private reloadDataService: ReloadDataService
  ) {
    this.frmCountry = signal(
      new FormGroup({
        name: new FormControl('', [
          Validators.required,
          Validators.maxLength(50),
        ]),
        description: new FormControl('', [Validators.maxLength(1024)]),
      })
    );
    this.form = new EventEmitter<Signal<FormGroup>>();
  }

  ngOnInit(): void {
    if (this.country()?.countryId !== undefined) {
      this.frmCountry().setControl(
        'countryId',
        new FormControl(this.country()?.countryId, [
          Validators.required,
          Validators.pattern(this.regexp),
        ])
      );
      this.frmCountry().get('name')?.setValue(this.country()?.name);
      this.frmCountry().setControl(
        'disabled',
        new FormControl<boolean>(!this.country()?.disabled || false)
      );
    }
    this.form.emit(computed(() => this.frmCountry()));
  }

  onSubmit(): void {
    if (this.frmCountry().valid) {
      if (this.country()?.countryId === undefined) {
        this.createCountry();
      } else {
        this.updateCountry();
      }
    }
  }

  private createCountry(): void {
    const body = this.frmCountry().value;
    this.httpService.post(URL_COUNTRY, body).subscribe({
      next: (response) => {
        console.log(response);
        this.reloadDataService.reload();
      },
      error: (error) => {
        console.error(error);
        handleException(error, this.snackBar);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }

  private updateCountry(): void {
    const body = this.frmCountry().value;
    body.disable = !body.disabled;
    delete body.disabled;

    const url = `${URL_COUNTRY}/${this.country()?.countryId}`;
    delete body.countryId;

    this.httpService.put(url, body).subscribe({
      next: (response) => {
        console.log(response);
        this.reloadDataService.reload();
      },
      error: (error) => {
        console.error(error);
        handleException(error, this.snackBar);
      },
      complete: () => {
        console.log('complete');
      },
    });
  }
}
