using System.Data.Entity;
using Utilitarios;

namespace Datos
{
    public class Mapeo : DbContext
    {
        static Mapeo()
        {
            Database.SetInitializer<Mapeo>(null);
        }
        private readonly string schema;

        public Mapeo(string schema)
            : base("name=Postgres")
        {
            this.schema = schema;
        }
        public DbSet<UUse> usuario { get; set; }
        public DbSet<UEmpleados> user { get; set; }
        public DbSet<Mesas> mesa{ get; set; }
        public DbSet<UAidioma> idioma { get; set; }
        public DbSet<UControles> controles { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<UComentarios> comentarios { get; set; }
        public DbSet<ULcomentarios> comentario { get; set; }
        public DbSet<UInformeRe> informeRe { get; set; }
        public DbSet<UReservation> reserva { get; set; }

        public DbSet<UInformeVe> informeVe { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(this.schema);

            base.OnModelCreating(builder);
        }
    }
}
