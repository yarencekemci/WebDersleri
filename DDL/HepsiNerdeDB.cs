using DDL.EntitiesTablolar;
using Microsoft.EntityFrameworkCore;

namespace DDL;

public class HepsiNerdeDB : DbContext
{
    public HepsiNerdeDB(DbContextOptions<HepsiNerdeDB> options) : base(options) 
    {
            
    }
    //DbContext=> bir db oldupunu gösterir, veritabanı işlemlerini gerçekleştirmek için kullanılan temel sınıftır. DbContext, veritabanı bağlantısını yönetir, varlıkları izler ve veritabanı işlemlerini gerçekleştirir. DbContext, Entity Framework Core'un temel bileşenlerinden biridir ve veritabanı işlemlerini kolaylaştırır.
    public DbSet<Urunler> Urunler { get; set; }
    public DbSet<Kategoriler> Kategoriler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //bu metot, Entity Framework Core'un model oluşturma sürecinde çağrılır ve veritabanı şemasını yapılandırmak için kullanılır. Bu metot içinde, Fluent API kullanarak varlıkların özelliklerini, ilişkilerini ve diğer yapılandırmalarını tanımlayabilirsiniz. Örneğin, tabloların anahtarlarını, ilişkilerini, veri türlerini ve diğer kısıtlamaları belirleyebilirsiniz. OnModelCreating metodu, veritabanı şemasının nasıl oluşturulacağını ve yapılandırılacağını kontrol etmek için önemli bir yerdir.
        
        
        base.OnModelCreating(modelBuilder);
    }

}