using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_323 : SimTemplate //* 废料铁匠 scrapsmith
	{
		//<b>嘲讽</b>，<b>战吼：</b>将两张2/4并具有<b>嘲讽</b>的步兵置入你的手牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.AV_323t, true, true);
            p.drawACard(CardDB.cardIDEnum.AV_323t, true, true);
        }
		
	}
}
