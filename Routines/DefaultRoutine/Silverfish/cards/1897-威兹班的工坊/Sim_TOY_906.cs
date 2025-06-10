using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：9 攻击力：4 生命值：12
	//Botface
	//机械腐面
	//[x]<b>Taunt</b>After this takes damage,get two random <b>Minis</b>.
	//<b>嘲讽</b>。在本随从受到伤害后，随机获取两张<b>微型</b>牌。
	class Sim_TOY_906 : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.None, m.own);
					p.drawACard(CardDB.cardIDEnum.None, m.own);
                }
            }
        }
		
	}
}
