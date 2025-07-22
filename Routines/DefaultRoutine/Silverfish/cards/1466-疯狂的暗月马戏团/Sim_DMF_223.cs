using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_223 : SimTemplate //* 知名表演者 Renowned Performer
	{
        //[x]<b>Rush</b><b>Deathrattle:</b> Summon two__1/1 Assistants with <b>Taunt</b>.__
        //<b>突袭，亡语：</b>召唤两个1/1并具有<b>嘲讽</b>的助演。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_223t), m.zonepos - 1, m.own);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_223t), m.zonepos, m.own);
        }

    }
}
