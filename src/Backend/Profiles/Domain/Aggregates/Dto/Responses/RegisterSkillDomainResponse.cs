﻿namespace Profiles.Domain.Aggregates.Dto.Responses
{
  public class RegisterSkillDomainResponse
  {
    public required string SkillId { get; init; }
    public string Name { get; init; }
    public bool Disabled { get; init; }
  }
}
