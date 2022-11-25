using System;
using System.ComponentModel.DataAnnotations;

namespace Karartek.Entities.Concrete
{
    public class Commision
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Court> Courts { get; set; }
        public IEnumerable<LawyerJudgment> LawyerJudgments { get; set; }
        public IEnumerable<Judgment> Judgments { get; set; }
    }
}

