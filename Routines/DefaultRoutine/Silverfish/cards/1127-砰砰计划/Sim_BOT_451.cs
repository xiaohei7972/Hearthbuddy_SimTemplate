using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_451 : SimTemplate //* 流电爆裂 Voltaic Burst
//Summon two 1/1 Sparks with <b>Rush</b>. <b>Overload:</b> (1)
//召唤两个1/1并具有<b>突袭</b>的“火花”。<b>过载：</b>（1） 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_102t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
			if (ownplay) p.ueberladung++;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}