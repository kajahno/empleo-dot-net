namespace EmpleoDotNet.Data
{
    public interface ISearchable
    {
        /// <summary>
        /// Las entidades deben poseer un identificador unico para poder realizar b�squedas
        /// cuando trabajemos con colecciones.
        /// </summary>
        int Id { get; set; }
    }
}