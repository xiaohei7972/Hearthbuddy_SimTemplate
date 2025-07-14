using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：3 生命值：3
	//Lightmender
	//圣光抚愈者
	//[x]<b><b>Taunt</b>.</b> <b>Choose One -</b>+3 Attack and <b>Divine Shield</b>;_or +3 Health and <b>Lifesteal</b>.
	//<b><b>嘲讽</b>。</b><b>抉择：</b>获得+3攻击力和<b>圣盾</b>；或者获得+3生命值和<b>吸血</b>。
	class Sim_EDR_257 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				hc.addattack += 3;
				hc.card.Shield = true;
            }
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				hc.addHp += 3;
				hc.card.lifesteal = true;
            }

        
        }
		
	}
}
