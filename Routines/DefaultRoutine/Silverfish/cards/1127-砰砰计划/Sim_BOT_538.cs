using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_538 : SimTemplate //* 火花引擎 Spark Engine
//<b>Battlecry:</b> Add a 1/1 Spark with <b>Rush</b> to_your hand.
//<b>战吼：</b>将一张1/1并具有<b>突袭</b>的“火花”置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.BOT_102t, own.own, true);
        }
	}
}