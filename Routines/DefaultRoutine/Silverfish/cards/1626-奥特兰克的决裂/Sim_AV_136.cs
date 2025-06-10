using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_136 : SimTemplate //* 狗头人监工 koboldtaskmaster
	{
		//<b>战吼：</b> 将两张可以使一个随从获得+2生命值的护甲碎片置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.AV_136t, true, true);
            p.drawACard(CardDB.cardIDEnum.AV_136t, true, true);
		}
	}
}
