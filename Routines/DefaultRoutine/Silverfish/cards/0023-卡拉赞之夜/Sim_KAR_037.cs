using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_037 : SimTemplate //* 鸟禽守护者 Avian Watcher
//<b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1and <b>Taunt</b>.
//<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1和<b>嘲讽</b>。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = (own.own) ? p.ownSecretsIDList.Count : p.enemySecretCount;
			if (num > 0)
			{
				p.minionGetBuffed(own, 1, 1);
				own.taunt = true;
			}
		}
	}
}