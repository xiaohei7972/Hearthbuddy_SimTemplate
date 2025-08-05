using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Plot of Sin
	//罪恶谋划
	//[x]Summon two 2/2 Treants. <b>Infuse (@):</b> Two 5/5 Ancients instead.
	//召唤两个2/2的树人。<b>注能（@）：</b>改为两个5/5的古树。
	class Sim_CORE_REV_336 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_336t2);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay);
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
