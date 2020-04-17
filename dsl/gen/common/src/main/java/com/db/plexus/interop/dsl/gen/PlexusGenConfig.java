/**
 * Copyright 2017-2020 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.db.plexus.interop.dsl.gen;

import com.beust.jcommander.Parameter;
import com.beust.jcommander.Parameters;

import java.util.ArrayList;
import java.util.List;

@Parameters(separators = " =")
public class PlexusGenConfig {

    @Parameter(names = {"-t", "--type"}, required = true)
    private String type;

    @Parameter(names = {"-i", "--input"})
    private String input = "*.interop";

    @Parameter(names = {"-o", "--out"})
    private String outDir = "./out";

    @Parameter(names = {"-of", "--outFile"})
    private String outFile;

    @Parameter(names = {"-b", "--baseDir"})
    private String baseDir = ".";

    @Parameter(names = {"-n", "--namespace"})
    private String namespace = "plexus";

    @Parameter(names = {"-pc", "--protoc"})
    private String protocPath = "protoc";

    @Parameter(names = {"-v", "--verbose"})
    private boolean verbose;

    @Parameter(names = {"-d", "--descriptors"})
    private boolean includeProtoDescriptors;

    @Parameter(names = {"-tb", "--targetBaseDir"})
    private String targetBaseDir;

    @Parameter(names = {"-e", "--exclude"})
    private String excludePattern;

    public String getExcludePattern() {
        return excludePattern;
    }

    public void setExcludePattern(String excludePattern) {
        this.excludePattern = excludePattern;
    }

    private List<String> externalDependencies = new ArrayList<>();

    private String messagesMetadata;

    public boolean isVerbose() {
        return verbose;
    }

    public void setVerbose(boolean verbose) {
        this.verbose = verbose;
    }

    public boolean isIncludeProtoDescriptors() {
        return includeProtoDescriptors;
    }

    public void setIncludeProtoDescriptors(boolean includeProtoDescriptors) {
        this.includeProtoDescriptors = includeProtoDescriptors;
    }

    public String getOutFile() {
        return outFile;
    }

    public void setOutFile(String outFile) {
        this.outFile = outFile;
    }

    public String getMessagesMetadata() {
        return messagesMetadata;
    }

    public void setMessagesMetadata(String messagesMetadata) {
        this.messagesMetadata = messagesMetadata;
    }

    public String getProtocPath() {
        return protocPath;
    }

    public void setProtocPath(String protocPath) {
        this.protocPath = protocPath;
    }

    public List<String> getExternalDependencies() {
        return externalDependencies;
    }

    public void setExternalDependencies(List<String> externalDependencies) {
        this.externalDependencies = externalDependencies;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String getInput() {
        return input;
    }

    public void setInput(String input) {
        this.input = input;
    }

    public String getOutDir() {
        return outDir;
    }

    public void setOutDir(String outDir) {
        this.outDir = outDir;
    }

    public String getBaseDir() {
        return baseDir;
    }

    public void setBaseDir(String baseDir) {
        this.baseDir = baseDir;
    }

    public String getNamespace() {
        return namespace;
    }

    public void setNamespace(String namespace) {
        this.namespace = namespace;
    }

    public String getTargetBaseDir() {
        return targetBaseDir;
    }

    public void setTargetBaseDir(String targetBaseDir) {
        this.targetBaseDir = targetBaseDir;
    }

    @Override
    public String toString() {
        return "PlexusGenConfig{" +
                "type='" + type + '\'' +
                ", input='" + input + '\'' +
                ", outDir='" + outDir + '\'' +
                ", outFile='" + outFile + '\'' +
                ", baseDir='" + baseDir + '\'' +
                ", namespace='" + namespace + '\'' +
                ", protocPath='" + protocPath + '\'' +
                ", verbose=" + verbose +
                ", includeProtoDescriptors=" + includeProtoDescriptors +
                ", target='" + targetBaseDir + '\'' +
                ", externalDependencies=" + externalDependencies +
                ", messagesMetadata='" + messagesMetadata + '\'' +
                '}';
    }
}
