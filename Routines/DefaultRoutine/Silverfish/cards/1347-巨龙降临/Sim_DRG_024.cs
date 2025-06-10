using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_024 : SimTemplate //* 空中悍匪 Sky Raider
	{
		//<b>Battlecry:</b> Add a random Pirate to your hand.
		//<b>战吼：</b>随机将一张海盗牌置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		
        {
			p.drawACard(CardDB.cardIDEnum.GVG_025, own.own, true);
        }
	}
}