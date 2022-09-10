using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestDbFirst.Models
{
    public partial class DeliveryVHGP_DBContext : DbContext
    {
        public DeliveryVHGP_DBContext()
        {
        }

        public DeliveryVHGP_DBContext(DbContextOptions<DeliveryVHGP_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerBuilding> CustomerBuildings { get; set; } = null!;
        public virtual DbSet<DeliveryShiftOfShipper> DeliveryShiftOfShippers { get; set; } = null!;
        public virtual DbSet<Hub> Hubs { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderEachShop> OrderEachShops { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<OrderTask> OrderTasks { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<ShopOwner> ShopOwners { get; set; } = null!;
        public virtual DbSet<TimeOfOrderStage> TimeOfOrderStages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SE140773\\SQLEXPRESS;Database=DeliveryVHGP_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.ToTable("Building");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FullName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CustomerBuilding>(entity =>
            {
                entity.ToTable("CustomerBuilding");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BuildingId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Room)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.CustomerBuildings)
                    .HasForeignKey(d => d.BuildingId)
                    .HasConstraintName("FK_CustomerBuilding_Building");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerBuildings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerBuilding_Customer");
            });

            modelBuilder.Entity<DeliveryShiftOfShipper>(entity =>
            {
                entity.ToTable("DeliveryShiftOfShipper");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.HubId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScheduleId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShipperId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TaskType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Hub)
                    .WithMany(p => p.DeliveryShiftOfShippers)
                    .HasForeignKey(d => d.HubId)
                    .HasConstraintName("FK_DeliveryShift_Hub");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.DeliveryShiftOfShippers)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_DeliveryShift_Schedule");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.DeliveryShiftOfShippers)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_DeliveryShift_Shift");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.DeliveryShiftOfShippers)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_DeliveryShift_Shipper");
            });

            modelBuilder.Entity<Hub>(entity =>
            {
                entity.ToTable("Hub");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BuildId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Room)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Build)
                    .WithMany(p => p.Hubs)
                    .HasForeignKey(d => d.BuildId)
                    .HasConstraintName("FK_Hub_Building");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.HubId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Total)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Hub)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.HubId)
                    .HasConstraintName("FK_Order_Hub");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderEachShopId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.OrderEachShop)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderEachShopId)
                    .HasConstraintName("FK_OrderDetail_OrderEachShop");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<OrderEachShop>(entity =>
            {
                entity.ToTable("OrderEachShop");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShopId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderEachShops)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderEachShop_Order");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.OrderEachShops)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_OrderEachShop_ShopOwner");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrderTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderTask");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShipperId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Task)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderTask_Order");

                entity.HasOne(d => d.Shipper)
                    .WithMany()
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_OrderTask_Shipper");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NetWeight)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ShopId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_Product_ShopOwner");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.EndTime)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StartTime)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("Shipper");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FullName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ShopOwner>(entity =>
            {
                entity.ToTable("ShopOwner");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BrandId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BuildingId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CloseTime)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OpenTime)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ShopOwners)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ShopOwner_Brand");
            });

            modelBuilder.Entity<TimeOfOrderStage>(entity =>
            {
                entity.ToTable("TimeOfOrderStage");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Time)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TimeOfOrderStages)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_TimeOfOrderStage_Order");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TimeOfOrderStages)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TimeOfOrderStage_OrderStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
