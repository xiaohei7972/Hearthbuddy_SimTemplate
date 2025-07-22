using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_830 : SimTemplate //* 残暴的恐龙术士 Cruel Dinomancer
//[x]<b>Deathrattle:</b> Summon arandom minion youdiscarded this game.
//<b>亡语：</b>随机召唤一个你在本局对战中弃掉的友方随从。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_205), m.zonepos-1, m.own); 
        }
	}
}