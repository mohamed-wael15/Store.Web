using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Store.Data.Contexts;
using Store.Data.Entities;
using System.Text.Json;

namespace Store.Repository
{
    public class StoreContextSeed
    {
        //    public static async Task SeedAsync(StoreDbContext context,ILoggerFactory loggerFactory)
        //    {
        //        try
        //        {
        //            if( context.ProductBrands != null && !context.ProductBrands.Any())
        //            {
        //                var brandData = File.ReadAllText("../Store.Repository/SeedData/brands.json");
        //                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

        //                if(brands is not null)
        //                    await context.ProductBrands.AddRangeAsync(brands);
        //            }

        //            if (context.ProductTypes != null && !context.ProductTypes.Any())
        //            {
        //                var TypeData = File.ReadAllText("../Store.Repository/SeedData/types.json");
        //                var types = JsonSerializer.Deserialize<List<ProductType>>(TypeData);

        //                if (types is not null)
        //                    await context.ProductTypes.AddRangeAsync(types);
        //            }

        //            if (context.Products != null && !context.Products.Any())
        //            {
        //                var productData = File.ReadAllText("../Store.Repository/SeedData/products.json");
        //                var product = JsonSerializer.Deserialize<List<Product>>(productData);

        //                if (product is not null)
        //                    await context.Products.AddRangeAsync(product);
        //            }

        //            if (context.DeliveryMethods != null && !context.DeliveryMethods.Any())
        //            {
        //                var deliveryMethodsData = File.ReadAllText("../Store.Repository/SeedData/delivery.json");
        //                var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryMethodsData);

        //                if (deliveryMethods is not null)
        //                    await context.DeliveryMethods.AddRangeAsync(deliveryMethods);
        //            }

        //            await context.SaveChangesAsync();
        //        }
        //        catch(Exception ex) 
        //        {
        //            var logger = loggerFactory.CreateLogger<StoreContextSeed>();
        //            logger.LogError(ex.Message);
        //        }
        //    }
        //}
        public static async Task SeedAsync(StoreDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                // التحقق من عدد المنتجات في قاعدة البيانات
                var productsCount = await context.Products.CountAsync();
                var brandsCount = await context.ProductBrands.CountAsync();
                var typesCount = await context.ProductTypes.CountAsync();
                var deliveryMethodsCount = await context.DeliveryMethods.CountAsync();

                // تسجيل المعلومات في الـ logs للتأكد من عدد السجلات
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogInformation($"Products Count: {productsCount}");
                logger.LogInformation($"Product Brands Count: {brandsCount}");
                logger.LogInformation($"Product Types Count: {typesCount}");
                logger.LogInformation($"Delivery Methods Count: {deliveryMethodsCount}");

             
                if (!context.ProductBrands.Any())
                {
                    var brandData = File.ReadAllText("../Store.Repository/SeedData/brands.json"); 
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);
                    if (brands != null && brands.Any())
                    {
                        await context.ProductBrands.AddRangeAsync(brands);
                        await context.SaveChangesAsync();
                        logger.LogInformation($"Seeded {brands.Count} Product Brands");
                    }
                }

                
                if (!context.ProductTypes.Any())
                {
                    var typeData = File.ReadAllText("../Store.Repository/SeedData/types.json"); 
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typeData);
                    if (types != null && types.Any())
                    {
                        await context.ProductTypes.AddRangeAsync(types);
                        await context.SaveChangesAsync();
                        logger.LogInformation($"Seeded {types.Count} Product Types");
                    }
                }

                
                if (!context.Products.Any())
                {
                    var productData = File.ReadAllText("../Store.Repository/SeedData/products.json"); 
                    var products = JsonSerializer.Deserialize<List<Product>>(productData);
                    if (products != null && products.Any())
                    {
                        await context.Products.AddRangeAsync(products);
                        await context.SaveChangesAsync();
                        logger.LogInformation($"Seeded {products.Count} Products");
                    }
                }

             
                if (!context.DeliveryMethods.Any())
                {
                    var deliveryMethodsData = File.ReadAllText("../Store.Repository/SeedData/delivery.json"); 
                    var deliveryMethods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryMethodsData);
                    if (deliveryMethods != null && deliveryMethods.Any())
                    {
                        await context.DeliveryMethods.AddRangeAsync(deliveryMethods);
                        await context.SaveChangesAsync();
                        logger.LogInformation($"Seeded {deliveryMethods.Count} Delivery Methods");
                    }
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError($"Error during seeding: {ex.Message}");
            }
        }

    }
}
