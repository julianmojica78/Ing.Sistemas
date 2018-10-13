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
        public DbSet<UFormularios> formulario { get; set; }
        public DbSet<UPedido> pedid { get; set; }
        public DbSet<UTokenRe> tokenre { get; set; }
        public DbSet<UCocinero> cocinero { get; set; }
        public DbSet<UCocinero1> cocinero1 { get; set; }
        public DbSet<UPlatos> platos { get; set; }
        public DbSet<UPlatos1> platos1 { get; set; }
        public DbSet<UPedidoplato> pedidos { get; set; }

        //public DbSet<UReservaplatos> reservas { get; set; }
        public DbSet<UContacto> contactenos { get; set; }
        public DbSet<UTokenRecu> recuperarToken { get; set; }
        //public DbSet<UUsuario> puntos { get; set; }
        public DbSet<ULclientes> clientes { get; set; }
        public DbSet<Uubicacion> pedido { get; set; }
        //public DbSet<UPedido> pedido1 { get; set; }
        public DbSet<UOtenerRe> obtener { get; set; }
        public DbSet<UPreserva> platoR { get; set; }
        public DbSet<ULReserva> listReser { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(this.schema);

            base.OnModelCreating(builder);
        }
    }
}
