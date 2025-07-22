using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_260 : SimTemplate //* 破霰元素 sleetbreaker
	{
		//<b>战吼：</b>将一张冷风置入你的手牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.AV_266, true, true);
        }
	}
}
