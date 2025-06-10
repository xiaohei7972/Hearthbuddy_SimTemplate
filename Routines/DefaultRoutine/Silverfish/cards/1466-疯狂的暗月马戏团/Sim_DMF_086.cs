using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_086 : SimTemplate //* 宠物乐园 Petting Zoo
	{
		//Summon a 3/3 Strider. Repeat for each <b>Secret</b> you control.
		//召唤一只3/3的陆行鸟。你每控制一个<b>奥秘</b>，重复一次。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_086e);//陆行鸟
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int num = (ownplay) ? p.ownSecretsIDList.Count : p.enemySecretList.Count;//数奥秘数量
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;//数随从数量
			for( int i=0; i <= num; i++)
			{
				p.callKid(kid, pos, ownplay);//召唤衍生物
			}
		}
		
	}
}
