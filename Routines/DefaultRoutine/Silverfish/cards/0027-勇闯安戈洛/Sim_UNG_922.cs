using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_922 : SimTemplate //* 探索安戈洛 Explore Un'Goro
//Replace your deck with_copies of "<b>Discover</b> a card."
//将你牌库里的所有卡牌替换成“<b>发现</b>一张牌”。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.evaluatePenality -= 20;
        }
    }
}