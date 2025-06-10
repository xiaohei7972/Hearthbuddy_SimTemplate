using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113t1 : SimTemplate //* 强化爆炸陷阱 improvedexplosivetrap
	{
		//<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$3点伤害。
		public override void onSecretPlay(Playfield p, bool ownplay, int number)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.allMinionOfASideGetDamage(!ownplay, dmg);
			Helpfunctions.Instance.ErrorLog("如果爆炸陷阱触发," + (!ownplay ? "我方" : "敌方") + "所有随从受到" + dmg + "点伤害！");
		}

	}
}
