using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Bait and Switch
	//诱骗诡计
	//<b>Secret:</b> When a friendly minion is attacked, give it +3/+3.
	//<b>奥秘：</b>当一个友方随从受到攻击时，使其获得+3/+3。
	class Sim_TTN_504 : SimTemplate
	{
        public override void onSecretPlay(Playfield p, bool ownplay, Minion attacker, Minion target, out int number)
        {
            number = 0;
            if (ownplay)
            {
				p.minionGetBuffed(target, 3, 3);
            }
            else
            {
				p.minionGetBuffed(target, 3, 3);

            }
        }
		
	}
}
