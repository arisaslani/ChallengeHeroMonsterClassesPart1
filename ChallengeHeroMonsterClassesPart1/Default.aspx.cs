using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Character hero = new Character();
            Character monster = new Character();

            hero.Name = "Aris";
            hero.Health = 100;
            hero.DamageMax = 20;
            hero.AttackBonus = 50;

            monster.Name = "myPhone";
            monster.Health = 100;
            monster.DamageMax = 15;
            monster.AttackBonus = 0;

            monster.Defend(hero.Attack());
            displayBattle(hero, monster);

            hero.Defend(monster.Attack());
            displayBattle(monster, hero);
        }

        public void displayBattle(Character attacker, Character defender)
        {
            resultLabel.Text += $"<br />{attacker.Name} attacks {defender.Name} with an attack and leaves him with {defender.Health} Health.";
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMax { get; set; }
        public int AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();

            return random.Next(1, 20);
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}