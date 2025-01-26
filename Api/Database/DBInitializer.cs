using Microsoft.EntityFrameworkCore;

using value_analysis_server.Api.Models;

namespace value_analysis_server.Api.Database
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { id = Guid.NewGuid(), code = "001", name = "Product 1", description = "Especificação / Descrição do produto genérico 1", quantity = 100, provider1 = 100, provider2 = 100, provider3 = 100, provider4 = 100, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "002", name = "Product 2", description = "Especificação / Descrição do produto genérico 2", quantity = 100, provider1 = 100, provider2 = 100, provider3 = 100, provider4 = 100, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "003", name = "Product 3", description = "Especificação / Descrição do produto genérico 3", quantity = 100, provider1 = 100, provider2 = 100, provider3 = 100, provider4 = 100, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "004", name = "Product 4", description = "Especificação / Descrição do produto genérico 4", quantity = 100, provider1 = 100, provider2 = 100, provider3 = 100, provider4 = 100, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "005", name = "Product 5", description = "Especificação / Descrição do produto genérico 5", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "006", name = "Product 6", description = "Especificação / Descrição do produto genérico 6", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "007", name = "Product 7", description = "Especificação / Descrição do produto genérico 7", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "008", name = "Product 8", description = "Especificação / Descrição do produto genérico 8", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "009", name = "Product 9", description = "Especificação / Descrição do produto genérico 9", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now },
                new Product() { id = Guid.NewGuid(), code = "010", name = "Product 10", description = "Especificação / Descrição do produto genérico 10", quantity = 100, provider1 = null, provider2 = null, provider3 = null, provider4 = null, selectedProvider = null, created_at = DateTime.Now, updated_at = DateTime.Now }
            );
        }
    }
}