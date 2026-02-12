using REST_Actor_Repo.Model;

namespace REST_Actor_Repo.ActorRepo
{
    public class Repo
    {
        private IEnumerable<Actor> actors = new List<Actor>();
        private int nextId = 1;

        public Actor? Get(int Id, string Name, int BirthYear)
        {
            return actors.FirstOrDefault(a => a.Id == Id && a.Name == Name && a.BirthYear == BirthYear); } public IEnumerable<Actor> GetAll() { return actors; } public Actor? Add(Actor actor) { if (actor == null || string.IsNullOrEmpty(actor.Name) || actor.BirthYear <= 0) { return null; } actor.Id = nextId++; var actorList = actors.ToList(); actorList.Add(actor); actors = actorList; return actor;
        }

        

    }
}
