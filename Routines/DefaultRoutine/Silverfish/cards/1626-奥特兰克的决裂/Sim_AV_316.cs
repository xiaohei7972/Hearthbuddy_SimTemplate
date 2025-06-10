using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_316 : SimTemplate //* 恐惧巫妖塔姆辛 dreadlichtamsin
	{
		//<b>战吼：</b>对所有随从造成3点伤害。将三张裂隙洗入你的牌库。抽三张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetDamage(!ownplay, 3);
            p.allMinionOfASideGetDamage(ownplay, 3);
            if (ownplay)
            {
                p.ownDeckSize += 3;

                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            else
            {
                p.enemyDeckSize += 3;

                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
           
        }	        
	}
}
