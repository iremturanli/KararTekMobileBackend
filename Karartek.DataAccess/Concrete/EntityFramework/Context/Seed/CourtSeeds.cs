using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context.Seed
{
    internal static class CourtSeeds
    {
        internal static readonly List<Court> courts = new List<Court>()
        {
            new Court() { Id = 1, CommissionId= 0,Name = "(BAKIRKÖY) DÖRDÜNCÜ AĞIR CEZA MAHKEMESİ" },
            new Court() { Id = 2, CommissionId=0, Name="(BAKIRKÖY) İKİNCİ AĞIR CEZA MAHKEMESİ" },
            new Court() { Id = 3, CommissionId=0,Name="(BAKIRKÖY) ONBİRİNCİ AĞIR CEZA MAHKEMESİ" },
            new Court() { Id = 4, CommissionId=1,Name="ÇOCUK AĞIR CEZA MAHKEMESİ"},
            new Court() { Id = 5, CommissionId=1, Name="SULH CEZA MAHKEMESİ"},
            new Court() { Id = 6, CommissionId=1, Name="1- AKSEKİ ASLİYE CEZA MAHKEMESİ" },
            new Court() { Id = 7, CommissionId=2, Name= "3. İCRA HUKUK MAHKEMESİ"},
            new Court() { Id = 8, CommissionId=2, Name= "5. AİLE MAHKEMESİ" },
            new Court() { Id = 9, CommissionId=3, Name= "SULH CEZA MAHKEMESİ"},
        };
    }
}
