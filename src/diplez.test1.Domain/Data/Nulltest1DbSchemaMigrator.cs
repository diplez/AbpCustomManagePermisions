using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace diplez.test1.Data;

/* This is used if database provider does't define
 * Itest1DbSchemaMigrator implementation.
 */
public class Nulltest1DbSchemaMigrator : Itest1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
