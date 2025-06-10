using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_118 : SimTemplate //* 十字军统领 Grand Crusader
//<b>Battlecry:</b> Add a random Paladin card to your hand.
//<b>战吼：</b>随机将一张圣骑士牌置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}