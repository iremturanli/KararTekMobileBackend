using System;
using System.ComponentModel.DataAnnotations;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class Commission
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Court>? Courts { get; set; }
        public IEnumerable<LawyerJudgment> LawyerJudgments { get; set; }
        public IEnumerable<Judgment> Judgments { get; set; }
    }
}

