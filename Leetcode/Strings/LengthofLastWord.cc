//https://leetcode.com/problems/length-of-last-word/

class Solution {
public:
	int lengthOfLastWord(string s) {
		if (!isValid(s))
			return 0;
		auto res = split(s);
		return res[res.size() - 1].size();
	}
private:
	vector<string> split(string s, string del = " ") {
		int start = 0;
		int end = s.find(del);
		vector<string> res;
		while (end != -1) {
			res.push_back(s.substr(start, end - start));
			start = end + del.size();
			end = s.find(del, start);
		}
		string last = s.substr(start, end - start);
		if (last != "")
			res.push_back(last);
		return res;
	}

	bool isValid(string s) {
		for (auto &chr : s) {
			if (chr != ' ')
				return true;
		}
		return false;
	}
};