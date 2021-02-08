    const canMakePaliQueries = (s, queries) => {
        const freq = [];

        for (let i = 0; i < 26; ++i) {
            freq[i] = new Int16Array(s.length + 1);
        }

        for (let i = 1; i <= s.length; ++i) {
            const code = s.charCodeAt(i - 1) - 97;
            ++freq[code][i - 1];
            for (let j = 0; j < 26; ++j) {
                freq[j][i] = freq[j][i - 1];
            }
            --freq[code][i - 1];
        }
        //console.log(freq);

        return queries.map(([start, end, count]) => {
            let sum = 0;
            for (let i = 0; i < 26; ++i) {
                console.log((freq[i][end + 1] - freq[i][start]) & 1)
                console.log((freq[i][end + 1] - freq[i][start]))
                sum += (freq[i][end + 1] - freq[i][start]) & 1;
            }
            return Math.floor(sum / 2) <= count;
        });

    };

console.log(canMakePaliQueries("abcda", [[3, 3, 0], [1, 2, 0], [0, 3, 1], [0, 3, 2], [0, 4, 1]]));





































