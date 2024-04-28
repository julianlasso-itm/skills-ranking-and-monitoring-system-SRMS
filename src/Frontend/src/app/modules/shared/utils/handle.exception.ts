import { MatSnackBar } from '@angular/material/snack-bar';

export const handleException = (error: any, snackBar: MatSnackBar) => {
  const errorMessages = new Map([
    ['409_23505', 'El registro que intentas crear o actualizar ya existe'],
    [
      '409_23503',
      'No es posible eliminar un registro porque tiene otros registros asociados',
    ],
  ]);

  const errorKey = `${error.status}_${error.error.Errors.substring(0, 5)}`;
  const message =
    errorMessages.get(errorKey) ?? error.error.Errors ?? 'Error desconocido';

  snackBar.open(message, 'Cerrar', { duration: 5000 });
};
