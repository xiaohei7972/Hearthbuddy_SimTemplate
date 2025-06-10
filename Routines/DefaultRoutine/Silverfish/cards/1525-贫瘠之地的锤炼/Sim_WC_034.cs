using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_034 : SimTemplate //* 小队集合 Party Up!
	{
        //Summon five 2/2 Adventurers with random bonus effects.
        //召唤五个2/2并具有随机效果的冒险者。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t), p.ownMinions.Count, true);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t2), p.ownMinions.Count, true);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t3), p.ownMinions.Count, true);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t4), p.ownMinions.Count, true);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t5), p.ownMinions.Count, true);
        }
    }
}
