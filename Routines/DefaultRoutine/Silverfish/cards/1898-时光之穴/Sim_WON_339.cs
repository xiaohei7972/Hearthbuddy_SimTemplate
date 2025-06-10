using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：3 生命值：7
	//Alley Armorsmith
	//兽人铸甲师
	//[x]<b>Taunt</b>Whenever this miniondeals damage, gainthat much Armor.
	//<b>嘲讽</b>每当本随从造成伤害时，获得等量的护甲值。
	class Sim_WON_339 : SimTemplate
	{
		public override void onDamageDealtByMinion(Playfield p, Minion attacker, int damageDone, bool ownplay)
        {
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, damageDone);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, damageDone);
            }
        }
	}
}
