


namespace Military_Elite.Models
{
    using Enums;
    using Interfaces;
    public class Misson : IMission
    {
        public Misson(string codeName,State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get;private set; }

        public State State { get; private set; }
        public void CompleteMission()
        {
            this.State = State.Finished;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State.ToString()}";
        }
    }
}
