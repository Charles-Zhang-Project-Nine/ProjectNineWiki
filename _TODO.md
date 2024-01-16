# TODO

<!-- Should we use projects? Projects is reserved for published Project Nine tasks to the public, which we shall not use now. 
Should we use Issues for todo? Issues should really be used for technical issues - some of the "todos" might be issues.
Should we use Discussion for ideas, advice, feature requests, and issues? Maybe. Again, that's for public use, for internal and collaborator use, we just use this TODO.
-->

*This TODO document is for internal use.*

- [ ] Replace license to Project Nine specific license

Basic Template (based on git-wiki):

- [x] (20240115) Mermaid rendering
    * Per https://github.com/TotalImagine-com/TotalImagine.com/commit/035a2731e5d3c12e21c03e8beb0bbde0391d9715#diff-907a69846a1f6b238f1c43199984197d12c7eab26f3c3adcd45d628b26644950
    * https://www.drassil.org/git-wiki/customize
    * Most likely we just need to use one of the hooks to inject the script reference we need
    * Done. See minimal configuration demo here: https://github.com/Charles-Zhang-Fork/git-wiki-skeleton/tree/Test-Mermaid-Manual
    * See https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3
- [x] (20240115) LaTex rendering
    * Per https://github.com/TotalImagine-com/TotalImagine.com/commit/17acd5403cadf70737d7e14b49d7e85261e77748
    * See https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3

Issues:

- [x] (20240115) Missing "Contents"/navigation sidebar - not rendering since https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/2
    * It's because the template requires show pages (which include "recent" pages) in order to show additional sidebar items
    * See: https://github.com/Charles-Zhang-Fork/git-wiki-skeleton/tree/Test-ModifySidebar
    * See: https://github.com/Charles-Zhang-Project-Nine/ProjectNineWiki/pull/3/commits/161a70e8103410a99ab598157a3d3a3b078ce590