using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_918 : SimTemplate //* 塔姆辛·罗姆 Tamsin Roame
	{
        //[x]Whenever you cast a Shadowspell that costs (1) or more,add a copy to your handthat costs (0).
        //每当你施放法力值消耗大于或等于（1）点的暗影法术时，将法术牌的一张复制置入你的手牌，其法力值消耗为（0）点。
        public override void onAuraStarts(Playfield p, Minion m)
        {
            p.anzTamsinroame++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.anzTamsinroame--;
        }
    }
}
