using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_316hp : SimTemplate //* 恐惧之链 chainsofdread
	{
		//<b>英雄技能</b> 将一张裂隙洗入你的牌库。抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.ownDeckSize += 1;
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
            else
            {
                p.enemyDeckSize += 1;
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
        }
	}
}
