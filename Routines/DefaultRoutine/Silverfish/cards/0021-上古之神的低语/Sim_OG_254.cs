using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_254 : SimTemplate //* Eater of Secrets 奥秘吞噬者
	{
		//Destroy all enemy Secrets. Gain +1/+1 for each.
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int buff = (own.own) ? p.enemySecretList.Count : p.ownSecretsIDList.Count;
            p.minionGetBuffed(own, buff, buff);
			if (own.own)
			{
				p.enemySecretList.Clear();
				p.enemySecretCount = 0;  //这行一定要更新，否则用到这个变量作为判断的测试用例会不过
			}
			else p.ownSecretsIDList.Clear();
		}
	}
}