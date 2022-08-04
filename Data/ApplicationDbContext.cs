using FMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FMS_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Lazy loading set off
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<T_OIMMAIN> T_OIMMAIN { get; set; }
        public DbSet<T_OIHMAIN> T_OIHMAIN { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<T_OIMMAIN>(opt =>
            {
                opt.HasKey(x => x.F_ID);
                opt.Property(x => x.F_MBLNo).HasMaxLength(20);
                opt.Property(x => x.F_RefNo).HasMaxLength(20);
                opt.Property(x => x.F_AgentRefNo).HasMaxLength(30);
                opt.Property(x => x.F_SMBLNo).HasMaxLength(20);
                opt.Property(x => x.F_mCommodity).HasMaxLength(100);
                opt.Property(x => x.F_SName).HasMaxLength(250);
                opt.Property(x => x.F_CName).HasMaxLength(250);
                opt.Property(x => x.F_NName).HasMaxLength(250);
                opt.Property(x => x.F_BName).HasMaxLength(100);
                opt.Property(x => x.F_Agent).HasMaxLength(100);
                opt.Property(x => x.F_Vessel).HasMaxLength(25);
                opt.Property(x => x.F_Voyage).HasMaxLength(15);
                opt.Property(x => x.F_LoadingPort).HasMaxLength(50);
                opt.Property(x => x.F_DisCharge).HasMaxLength(50);
                opt.Property(x => x.F_LCLFCL).HasMaxLength(1);
                opt.Property(x => x.F_ITNo).HasMaxLength(12);
                opt.Property(x => x.F_ITPlace).HasMaxLength(20);
                opt.Property(x => x.F_ITClass).HasMaxLength(5);
                opt.Property(x => x.F_FinalDelivery).HasMaxLength(50);
                opt.Property(x => x.F_FinalDest).HasMaxLength(25);
                opt.Property(x => x.F_PPCC).HasMaxLength(2);
                opt.Property(x => x.F_PaidPlace).HasMaxLength(30);
                opt.Property(x => x.F_SVCCNo).HasMaxLength(30);
                opt.Property(x => x.F_FeederVessel).HasMaxLength(25);
                opt.Property(x => x.F_MoveType).HasMaxLength(25);
                opt.Property(x => x.F_ExpRLS).HasMaxLength(1);
                opt.Property(x => x.F_FileClosed).HasMaxLength(1);
                opt.Property(x => x.F_ClosedBy).HasMaxLength(10);
            });

            modelBuilder.Entity<T_OIHMAIN>(opt =>
            {
                opt.HasKey(x => x.F_ID);
                opt.Property(x => x.F_HBLNo).HasMaxLength(20);
                opt.Property(x => x.F_SName).HasMaxLength(250);
                opt.Property(x => x.F_CName).HasMaxLength(250);
                opt.Property(x => x.F_NName).HasMaxLength(250);
                opt.Property(x => x.F_BName).HasMaxLength(100);
                opt.Property(x => x.F_CustRefNo).HasMaxLength(50);
                //opt.Property(x => x.F_Punit).HasMaxLength(10);
                opt.Property(x => x.F_Commodity).HasMaxLength(100);
                opt.Property(x => x.F_HSCODE).HasMaxLength(25);
                opt.Property(x => x.F_MarkPkg).HasMaxLength(800);
                opt.Property(x => x.F_Description).HasMaxLength(800);
                opt.Property(x => x.F_MarkGross).HasMaxLength(800);
                opt.Property(x => x.F_MarkMeasure).HasMaxLength(800);
                opt.Property(x => x.F_ExpRLS).HasMaxLength(1);
                opt.Property(x => x.F_FinalDest).HasMaxLength(25);
                opt.Property(x => x.F_ITClass).HasMaxLength(5);
                opt.Property(x => x.F_ITNo).HasMaxLength(20);
                opt.Property(x => x.F_ITPlace).HasMaxLength(20);
                opt.Property(x => x.F_DcodeCustom).HasMaxLength(5);
                opt.Property(x => x.F_FcodeCustom).HasMaxLength(5);
                opt.Property(x => x.F_ForeignDest).HasMaxLength(25);
                opt.Property(x => x.F_PPCC).HasMaxLength(2);
                //opt.Property(x => x.F_SManID).HasMaxLength(10);
                opt.Property(x => x.F_Mark).HasMaxLength(800);                
                opt.Property(x => x.F_FileClosed).HasMaxLength(1);
                opt.Property(x => x.F_ClosedBy).HasMaxLength(10);
                opt.Property(x => x.F_Operator).HasMaxLength(10);
                //opt.Property(x => x.F_SelectContainer).HasMaxLength(1);
                opt.Property(x => x.F_MoveType).HasMaxLength(15);
                opt.Property(x => x.F_Nomi).HasMaxLength(1);
                opt.Property(x => x.F_Memo).HasMaxLength(800);
                //opt.Property(x => x.F_IMemo).HasMaxLength(800);
                //opt.Property(x => x.F_PMemo).HasMaxLength(800);
                //opt.Property(x => x.F_DoorMove).HasMaxLength(1);
                opt.Property(x => x.F_AMSBLNO).HasMaxLength(16);
                opt.Property(x => x.F_ISFNO).HasMaxLength(20);
            });
        }
        
    }
}
