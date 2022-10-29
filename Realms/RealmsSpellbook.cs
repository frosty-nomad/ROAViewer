using System.Collections.Generic;
using System.Linq;

namespace Realms
{
    public class RealmsSpellbook
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public List<RealmsSpell> Spells { get; set; }

        public List<SpellbookRow> ToSpellbookRows()
        {
            return Spells.Select(s => new SpellbookRow
            {
                BookName = Name,
                SpellName = s.Name,
                Color = s.Color,
                Cost = s.Cost,
                DamageType = s.DamageType,
                Effect = s.Effect,
                Power = s.Power
            }).ToList();
        }

        public static List<RealmsSpellbook> LoadSpellbooks(List<RealmsItem> items, List<RealmsSpell> spells)
        {
            var books = new List<RealmsSpellbook>();

            foreach (var i in items.Where(t => RealmsItem.IsType(RealmsItemType.Book, t.Data)))
            {
                var book = new RealmsSpellbook
                {
                    Name = i.Name,
                    Spells = new List<RealmsSpell>()
                };
                for (var s = 0; s < 10; s++)
                {
                    var cur = i.Data[s + 4];
                    if (cur < 255 && cur < spells.Count)
                    {
                        book.Spells.Add(spells[cur]);
                    }
                }
                books.Add(book);
            }

            return books;
        }
    }

    public class SpellbookRow
    {
        public string BookName { get; set; }
        public string SpellName { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
        public string DamageType { get; set; }
        public string Effect { get; set; }
        public int Power { get; set; }
    }
}
