using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：0
	//Runes of Frost
	//冰霜符文
	//The next spell you castcosts (3) less and has <b>Spell_Damage_+3</b>.
	//你施放的下一个法术法力值消耗减少（3）点且拥有<b>法术伤害+3</b>。
	class Sim_TTN_737t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true, true);
        }
    }
}
