using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_648 : SimTemplate //* 总督察 Chief Inspector
//<b>Battlecry:</b> Destroy all enemy <b>Secrets</b>.
//<b>战吼：</b>摧毁所有敌方<b>奥秘</b>。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.enemySecretList.Clear();
            else p.ownSecretsIDList.Clear();
		}
	}
}