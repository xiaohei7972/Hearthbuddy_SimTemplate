using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_123 : SimTemplate //* 打开兽笼 Open the Cages
	{
		//[x]<b>Secret:</b> When yourturn starts, if you control two minions, summon anAnimal Companion.
		//<b>奥秘：</b>当你的回合开始时，如果你控制着两个随从，召唤一个动物伙伴。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);//misha
		public override void onSecretPlay(Playfield p, bool ownplay, int number)
		{
			int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
		}    
		
	}
}
