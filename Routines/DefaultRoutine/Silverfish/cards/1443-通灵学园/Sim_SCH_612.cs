using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_612 : SimTemplate //* 雕琢符文 Runic Carvings
	{
		//<b>Choose One -</b> Summon four 2/2 Treant Totems; or <b>Overload:</b> (2) to summon them with <b>Rush</b>.
		//<b>抉择：</b>召唤四个2/2的树人图腾；或者<b>过载：</b>（2）召唤四个2/2并具有<b>突袭</b>的树人图腾。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_612t);
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				for (int i = 0; i < 4; i++)
				{
					int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
					if (pos < 7) p.callKid(kid, pos, ownplay);
				}
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				if (ownplay) p.ueberladung += 2;
				for (int i = 0; i < 4; i++)
				{
					int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
					if (pos < 7)
					{ 
						p.callKid(kid, pos, ownplay);
						if (ownplay) p.ownMinions[pos].rush++;
						else p.enemyMinions[pos].rush++;
					}
				}
			}
		}
		
	}
}
