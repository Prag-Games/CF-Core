namespace CF_Core.Models;

public interface IDamageModifier
{
    DamageContext Modify(DamageContext context);
}