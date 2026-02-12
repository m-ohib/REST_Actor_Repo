namespace REST_Actor_Repo.Model
{
    public class Actor
    {
        public string? Name  {get;set;}
        public int Id { get; set; }
        public int BirthYear { get; set; }
        
        override public string ToString() { return $"Actor: {Name}, Id: {Id}, BirthYear: {BirthYear}"; }


    }
}
