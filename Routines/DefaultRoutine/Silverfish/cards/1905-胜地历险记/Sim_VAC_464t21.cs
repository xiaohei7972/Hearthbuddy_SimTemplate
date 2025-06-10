using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：4
	//Dr. Boom's Boombox
	//砰砰博士的砰砰箱
	//[x]Summon 7 'Boom Bots'.
	//召唤七个“砰砰机器人”。
	class Sim_VAC_464t21 : SimTemplate
	{

        CardDB.Card boomBot = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int availableSlots = ownplay ? (7 - p.ownMinions.Count) : (7 - p.enemyMinions.Count);

            for (int i = 0; i < availableSlots; i++)
            {
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(boomBot, pos, ownplay); // 召唤砰砰机器人
            }
        }
    }
}
