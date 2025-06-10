using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_252 : SimTemplate //* 相位追猎者 Phase Stalker
	{
		//[x]After you use your HeroPower, cast a <b>Secret</b>from your deck.
		//在你使用你的英雄技能后，从你的牌库中施放一个<b>奥秘</b>。
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{				
				p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_610);
			}
        }


	}
}