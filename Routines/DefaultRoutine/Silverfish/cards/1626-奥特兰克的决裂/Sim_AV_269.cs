using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_269 : SimTemplate //* 侧翼合击 flankingmaneuver
	{
		//召唤一个4/2并具有<b>突袭</b>的恶魔。如果它在本回合中死亡，再召唤一个。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_269t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (pos < 7)
            {
                p.callKid(kid, pos, ownplay, false);
                foreach (GraveYardItem gyi in p.diedMinions.ToArray())
                {
                    if (gyi.own == ownplay && CardDB.Instance.getCardDataFromID(gyi.cardid) == kid)
                    {
                        p.callKid(kid, pos, ownplay, false);
                        break;
                    }
                }               
                p.evaluatePenality -= 6;
            }
        }
		
	}
}
