using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_610 : SimTemplate //explosivetrap
	{
        //todo secret
//    geheimnis:/ wenn euer held angegriffen wird, erleiden alle feinde $2 schaden.
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
            Helpfunctions.Instance.ErrorLog("如果爆炸陷阱触发," + (!ownplay ? "我方" : "敌方") + "所有随从受到" + dmg +"点伤害！");
        }

	}

}