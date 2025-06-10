using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_027 : SimTemplate //* 镜像 Mirror Image
	{
		//Summon two 0/2 minions with <b>Taunt</b>.
		//召唤两个0/2，并具有<b>嘲讽</b>的随从。
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_mirror);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;            
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}