using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Cursed Souvenir
	//咒怨纪念品
	//Give a minion +3/+3 and "At the start of your turn, deal 3 damage to your hero."
	//使一个随从获得+3/+3和“在你的回合开始时，对你的英雄造成3点伤害”。
	class Sim_VAC_944 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 使一个随从获得+3/+3
            p.minionGetBuffed(target, 3, 3);
        }
    }
}
