namespace HREngine.Bots
{
	class Sim_DALA_Mage_HP2 : SimTemplate //* 冰霜灼烧 Frostburn
//<b>Hero Power</b><b>Freeze</b> a character.If it's already <b>Frozen</b>, deal $2 damage.
//<b>英雄技能</b><b>冻结</b>一个角色。如果该角色已经<b>冻结</b>，则对其造成$2点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}