console.log(((strs) => {
    let res = [...strs[0]]
    for(let i = 1;i < strs.length;++i)
    {
        res = res.filter(char => {
            if(strs[i].indexOf(char) != -1){
                strs[i] = strs[i].replace(char,"")
                return true;
            }
            return false;
        })
    }
    return res;
})(["bella","label","roller"]));