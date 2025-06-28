using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Soothing Melody
	//抚慰弦律
	//[x]Refresh your Hero Power.
	//复原你的英雄技能。
	class Sim_JAM_026a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.anzUsedOwnHeroPower = 0;
			p.ownAbilityReady = true;
		}

	}
}
