using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：1 攻击力：3 生命值：3
	//Catch of the Day
	//当日渔获
	//[x]<b>Rush</b><b>Battlecry:</b> Summon a 2/1Worm for your opponent.
	//<b>突袭</b>。<b>战吼：</b>为你的对手召唤一只2/1的鱼虫。
	class Sim_VAC_412 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 召唤一只2/1的鱼虫给对手
            int pos = own.own ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_412t), pos, !own.own, false);
        }

    }
}
