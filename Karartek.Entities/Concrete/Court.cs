using System;
namespace Karartek.Entities.Concrete
{
    public class Court
    {
        public Court()
        {
            this.Judgments = new List<Judgment>();
        }

        public int Id { get; set; }
        public int CommisionId { get; set; }
        public string Name { get; set; }

        public Commision Commision{ get; set; }

        public IEnumerable<Judgment> Judgments { get; set; }
        public IEnumerable<LawyerJudgment> LawyerJudgments { get; set; }
    }
}

